import wx, wx.media, webbrowser

class windowClass(wx.Frame):

    def __init__(self, *args, **kwargs):
        super(windowClass, self).__init__(size = (800,600), *args, **kwargs)
        self.GUI()



    def GUI(self):
        self.imagePresent = False
        self.textPresent = False
        self.panel = wx.Panel(self)
        #create menuBar and buttons
        menuBar = wx.MenuBar()
        fileButton = wx.Menu()
        editButton = wx.Menu()
        exitItem = wx.MenuItem(fileButton, wx.ID_EXIT, 'Quit\tCtrl+Q')
        removeImageItem = wx.MenuItem(editButton, wx.ID_ANY, \
                                      'Remove Image\tCtrl+R')
        fileButton.AppendItem(exitItem)
        editButton.AppendItem(removeImageItem)
        menuBar.Append(fileButton, 'File')
        menuBar.Append(editButton, 'Edit')
        self.SetMenuBar(menuBar)
        self.Bind(wx.EVT_MENU, self.Quit, exitItem)
        self.Bind(wx.EVT_MENU, self.removeImage, removeImageItem)
        
        #create tool bar with icon
        toolBar = self.CreateToolBar()
        linkToolButton = toolBar.AddLabelTool(wx.ID_ANY, 'JLP', \
                                wx.Bitmap('jlp_icon.png'))
        toolBar.Realize()
        self.Bind(wx.EVT_TOOL, self.openLink, linkToolButton)


        #create media player
        self.player = wx.media.MediaCtrl(self.panel, \
                                    style = wx.SIMPLE_BORDER, \
                                    szBackend = wx.media.MEDIABACKEND_WMP10)
        #show controls for player, doesnt seem to work.....
        self.player.ShowPlayerControls(wx.media.MEDIACTRLPLAYERCONTROLS_DEFAULT)
        #when media loaded event is caught, runs onSongLoaded
        self.Bind(wx.media.EVT_MEDIA_LOADED, self.onSongLoaded)
        #initialize sizer
        self.sizer = wx.BoxSizer()
        #make load, play, and pause buttons
        self.loadButton = wx.Button(self.panel, label = "Load")
        self.loadButton.Bind(wx.EVT_BUTTON, self.loadSong)
        self.loadButton.SetBitmap(wx.Bitmap('load_button_icon.png'))
        self.playButton = wx.Button(self.panel, label = 'Play')
        self.playButton.SetBitmap(wx.Bitmap('play_button_icon.png'))
        self.playButton.Bind(wx.EVT_BUTTON, self.playClick)
        self.pauseButton = wx.Button(self.panel, label = "Pause")
        self.pauseButton.Bind(wx.EVT_BUTTON, self.pauseClick)
        self.pauseButton.SetBitmap(wx.Bitmap('pause_button_icon.png'))
        #place player and buttons in sizer
        self.sizer.Add(self.player)
        self.sizer.Add(self.loadButton)
        self.sizer.Add(self.playButton)
        self.sizer.Add(self.pauseButton)
        #put sizer in frame
        self.SetSizer(self.sizer)
        
        #show the panel
        self.Show(True)

    #create the openLink function
    def openLink(self, e):
        new = 2
        url = "https://soundcloud.com/j-lp"
        webbrowser.open(url, new = new)

    #create onSongLoaded function
    def onSongLoaded(self, e):
        #catches media loaded event, enables play button
        self.playButton.Enable()

    #create load function
    def loadSong(self, e):
        self.playButton.Disable()
        #makes single choice box to choose song
        songChooseBox = wx.SingleChoiceDialog(None, \
                    'What song would you like to load?', 'Choose a song', \
                    ['the final fight remix', 'seaside village', '8bit theme'])
        if songChooseBox.ShowModal() == wx.ID_OK:
            #retrieves user choice and sets correct mp3 and image path
            songToPlay = songChooseBox.GetStringSelection()
            if songToPlay == 'the final fight remix':
                mp3_path = r'final_fight_remix.mp3'
                image_path = r'8bit_pulp_fiction.jpg'
                song_text = 'the final fight remix'
            if songToPlay == 'seaside village':
                mp3_path = r'seaside_village.mp3'
                image_path = r'8bit_nes.jpg'
                song_text = 'seaside village'
            if songToPlay == '8bit theme':
                mp3_path = r'8bit_theme.mp3'
                image_path = r'8bit_mage.png'
                song_text = '8bit theme'
        #loads user chosen song and song image
        if self.imagePresent == True:
            self.image.Destroy()
        if self.textPresent == True:
            self.text.Destroy()
        self.image = wx.StaticBitmap(self.panel, size = (200,200), \
                                     pos = (50,50))
        self.image.SetBitmap(wx.Bitmap(image_path))
        self.player.Load(mp3_path)
        self.text = wx.StaticText(self.panel, -1, "Now Playing: "+song_text, \
                                  pos = (400,50))
        self.imagePresent = True
        self.textPresent = True

    #create play function
    def playClick(self, e):
        #plays loaded song
        self.player.Play()
        
    #create pause function
    def pauseClick(self, e):
        #pauses loaded song
        self.player.Pause()

    #create remove image function
    def removeImage(self, e):
        if self.imagePresent == True:
            self.image.Destroy()
            self.imagePresent = False

    #create quit function
    def Quit(self, e):
        self.Close()

        
def main():
    app = wx.App()
    app.locale = wx.Locale(wx.LANGUAGE_ENGLISH)
    windowClass(None)
    app.MainLoop()

main()
