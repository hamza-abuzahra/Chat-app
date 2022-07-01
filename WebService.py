# from requests import request
from http.server import executable
from os import curdir
from datetime import datetime

from colorama import Cursor
from flask import Flask, request
import pymysql.cursors

# now = datetime.now()
# current_time = now.strftime("%Y-%M-%d %H:%M:%S")
# print(current_time)

class Db:
    def __init__(self):
        self.connection = pymysql.connect(host="localhost", user="root", password="", cursorclass=pymysql.cursors.DictCursor)
        self.cursor = self.connection.cursor()
        self.count = 1
        try:
            self.cursor.execute("use employeeinfo")
            self.cursor.execute("select * from info")
            result = self.cursor.fetchall()
            print(result)
            self.cursor.execute("select * from messagelog")
            result = self.cursor.fetchall()
            self.count = len(result) + 1
        except Exception:
            self.populate() 
        

    def populate(self):
        self.cursor.execute("source ")

    def isPasswordValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\";")
        result = self.cursor.fetchall()
        if len(result) > 0:
            paswrd = result[0]['Epassword']
            if password == paswrd:
                return True
        print(result)
        return False

    def isUnValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\";")
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
    
    def recordmsg(self, msg, reciever, sender):
        self.cursor.execute(f"select * from info where Eemail = \"{sender}\";")
        senderinfo = self.cursor.fetchall()
        self.cursor.execute(f"select * from info where Eemail = \"{reciever}\";")
        recieverinfo = self.cursor.fetchall()
        senderid = senderinfo[0]['Eid']
        recieverid = recieverinfo[0]['Eid']
        now = datetime.now()
        current_time = now.strftime("%Y-%m-%d %H:%M:%S")
        print(current_time)
        sqlcommand = f"insert into messagelog values({self.count}, {senderid}, {recieverid}, \"{msg}\", \'{current_time}\')"
        self.cursor.execute(sqlcommand)
        self.connection.commit()
        self.count += 1
        return senderid, recieverid
    
    def getallmsgs(self, sender, reciever):
        sqlcommand = f"select * from info where Eemail = \"{sender}\""
        self.cursor.execute(sqlcommand)
        senderinfo = self.cursor.fetchall()
        sqlcommand = f"select * from info where Eemail = \"{reciever}\""
        self.cursor.execute(sqlcommand)
        recieverinfo = self.cursor.fetchall()
        print(senderinfo)
        print(recieverinfo)
        senderid = senderinfo[0]["Eid"]
        recieverid = recieverinfo[0]["Eid"]
        #  union 
        sqlcommand = f"select * from messagelog where (senderid = {senderid} and recieverid = {recieverid})"
        sqlcommand2 = f"select * from messagelog where (senderid = {recieverid} and recieverid = {senderid})"
        self.cursor.execute(f"{sqlcommand} union {sqlcommand2} order by MessageTime")
        results = self.cursor.fetchall()
        print(results)
        return results
    
    def employees(self):
        pass


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
    
@app.route("/sendchat", methods=['get'])
def sendcaht():
    msg = request.args.get("msg", None)
    sender = request.args.get("sender", None)
    reciever = request.args.get("reciever", None)
    senderid, recieverid = db.recordmsg(msg, reciever, sender)
    return f"<p>{senderid},{recieverid}</p>"

@app.route("/getchat", methods=["get"])
def getchat():
    sender = request.args.get("sender", None)
    reciever = request.args.get("reciever", None)
    msgs = db.getallmsgs(sender, reciever)
    return f"<p>{msgs}</p>"

@app.route("/employees")
def employees():
    results = db.employees()


app.run(debug=True, port=5000)