import shutil
import os


def fileMover():
    #set source and destination folder paths
    source = r'C:\Users\joshl_000\Desktop\Folder A'
    destination = r'C:\Users\joshl_000\Desktop\Folder B'
    for files in os.listdir(source):
        #set source file path
        source_file = os.path.join(source, files)
        print 'Moving ' + str(source_file) + ' to...'
        #set destination file path
        destination_file = os.path.join(destination, files)
        print str(destination_file)
        #move file
        shutil.move(source_file, destination_file)


def main():
    fileMover()


if __name__ == "__main__": main()
