# from requests import request
from http.server import executable
from os import curdir
from datetime import datetime

from colorama import Cursor
from setuptools import Command
from flask import Flask, request
import pymysql.cursors


class Db:
    def __init__(self):
        self.connection = pymysql.connect(host="localhost", user="root", password="", cursorclass=pymysql.cursors.DictCursor)
        self.cursor = self.connection.cursor()
        self.count = 1
        try:
            self.cursor.execute("use employeeinfo")
            self.cursor.execute("select * from info")
            result = self.cursor.fetchall()
            self.cursor.execute("select * from messagelog")
            result = self.cursor.fetchall()
            self.count = len(result) + 1
            self.cursor.execute("SET GLOBAL max_allowed_packet=67108864")
            self.connection.commit()
        except Exception:
            self.populate() 
        

    def populate(self):
        self.cursor.execute("source employeeinfo.sql")
        self.cursor.execute("source MessageLog.sql")
        self.cursor.execute("SET GLOBAL max_allowed_packet=67108864")
        self.connection.commit()
        

    def isPasswordValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\";")
        result = self.cursor.fetchall()
        if len(result) > 0:
            paswrd = result[0]['Epassword']
            if password == paswrd:
                return True
        return False

    def isUnValid(self, username, password):
        self.cursor.execute(f"select * from info where Eemail = \"{username}\";")
        result = self.cursor.fetchall()
        if len(result) > 0:
            paswrd = result[0]['Epassword']
            if paswrd != '':
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
        senderid = senderinfo[0]["Eid"]
        recieverid = recieverinfo[0]["Eid"]
        #  union 
        if senderid == 11:
            sqlcommand = f"select * from messagelog where (senderid = {senderid})"
            sqlcommand2 = f"select * from messagelog where (recieverid = {senderid})"
        elif recieverid == 11:
            sqlcommand = f"select * from messagelog where (senderid = {recieverid})"
            sqlcommand2 = f"select * from messagelog where (recieverid = {recieverid})"
        else:
            sqlcommand = f"select * from messagelog where (senderid = {senderid} and recieverid = {recieverid})"
            sqlcommand2 = f"select * from messagelog where (senderid = {recieverid} and recieverid = {senderid})"
        self.cursor.execute(f"{sqlcommand} union {sqlcommand2} order by MessageTime")
        results = self.cursor.fetchall()
        return results
    
    def updateaccesstime(self, username):
        now = datetime.now()
        current_time = now.strftime("%Y-%m-%d %H:%M:%S")
        sqlcommand = f"update info set Elastacess = \'{current_time}\' where Eemail = \'{username}\'"
        self.cursor.execute(sqlcommand)
        self.connection.commit()
        results = self.cursor.fetchall()
        return results

    def getaccesstime(self):
        sqlcommand = f"select Eemail, ElastAcess from info"
        self.cursor.execute(sqlcommand)
        result = self.cursor.fetchall()
        return result


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

@app.route("/updateaccesstime", methods=['get'])
def udpateaccesstime():
    username = request.args.get("username", None)
    db.updateaccesstime(username)
    return "<p>ok</p>"

@app.route("/checkaccesstime")
def checkaccesstime():
    msg = db.getaccesstime()
    return f"<p>{msg}</p>"

app.run(debug=True, port=5000)