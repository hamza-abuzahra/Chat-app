# from requests import request
from http.server import executable
from os import curdir

from colorama import Cursor
from flask import Flask, request
import pymysql.cursors

class Db:
    def __init__(self):
        self.connection = pymysql.connect(host="localhost", user="root", password="", cursorclass=pymysql.cursors.DictCursor)
        self.cursor = self.connection.cursor()
        try:
            self.cursor.execute("use employeeinfo")
            self.cursor.execute("select * from info")
            result = self.cursor.fetchall()
            print(result)
        except Exception:
            self.populate() 
        

    def populate(self):
        pass

    def isPasswordValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\"")
        result = self.cursor.fetchall()
        if len(result) > 0:
            paswrd = result[0]['Epassword']
            if password == paswrd:
                return True
        print(result)
        return False

    def isUnValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\"")
        result = self.cursor.fetchall()
        print(result)
        if len(result) > 0:
            paswrd = result[0]['Epassword']
            if paswrd != '':
                print("you are already registerd")
                return False
            else:
                self.cursor.execute(f"UPDATE info SET Epassword = \"{password}\" WHERE Eemail = \"{username}\";")
                self.connection.commit()
                return True

db = Db()
db.cursor.execute("select * from info")
print(db.cursor.fetchall())
app = Flask(__name__)

@app.route("/")
def hello_world():
    return "<h1>Hello, World!</h1>"


@app.route("/auth", methods=['get'])
def auth():
    username = request.args.get("username", None)
    password = request.args.get("password", None)
    if db.isPasswordValid(username, password):
        return "<p>True</p>"
    return "<p>False</p>"

@app.route("/signup", methods=['get'])
def signup():
    username = request.args.get("username", None)
    password = request.args.get("password", None)
    if db.isUnValid(username, password):
        return "<p>True</p>"
    return "<p>False</p>"
    
app.run(debug=True, port=5000)