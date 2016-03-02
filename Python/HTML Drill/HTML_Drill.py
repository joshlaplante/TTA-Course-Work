def main():

    html = open('index.html', 'w')
    content = """<html>
    <body>
    Stay tuned for our amazing summer sale!
    </body>
    </html>"""
    html.write(content)
    html.close()

if __name__ == "__main__": main()