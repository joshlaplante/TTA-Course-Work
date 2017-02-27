import os
import shutil
import datetime


def timedCopier(now, limit):
    #set source and destination folder paths
    source = r'C:\Users\joshl_000\Desktop\Folder A'
    destination = r'C:\Users\joshl_000\Desktop\Folder B'
    for files in os.listdir(source):
        #set source file path
        source_file = os.path.join(source, files)
        #get last modified time of file
        mtimestamp = os.path.getmtime(source_file)
        mdatetime = datetime.datetime.fromtimestamp(mtimestamp)
        #check if modified time is within limit (last 24 hours)
        if limit < mdatetime < now:
            #set destination file path
            destination_file = os.path.join(destination, files)
            print 'Copying ' + str(source_file) + ' to...'
            print str(destination_file)
            #copy over file
            shutil.copy(source_file, destination_file)
    



def main():
    #get current time
    now = datetime.datetime.now()
    #get limit time (24 hours back)
    limitdiff = datetime.timedelta(hours = 24)
    limit = now - limitdiff
    #run timeScript with current and limit times
    timedCopier(now, limit)

if __name__ == "__main__": main()
