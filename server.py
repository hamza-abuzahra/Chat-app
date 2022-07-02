# from argparse import ArgumentError
# from ast import Try
# from urllib import response
import requests
import socket as sk
from _thread import *
import datetime as datetime

from AesEverywhere import aes256
from threading import *         
import time

url = "http://127.0.0.1:5000/"
active_users = []
s = Semaphore()



class Server():
    # constructor creates the socket object 
    def __init__(self, port):
        self.socket = sk.socket(sk.AF_INET, sk.SOCK_STREAM)
        self.port = port
    


    # start listening for a client to connect, and then calls auth function 
    # to check the login information of the client
    def startListening(self):
        host = sk.gethostname()
        self.socket.bind(('localhost', self.port))
        self.socket.listen(5)
        print("socket is listening")
        while True:
            self.accept_connections()

    def accept_connections(self):
        c, self.address = self.socket.accept()
        print("connected successfully")
        # ask the client for public key
        self.send(c, "=")
        self.send(c, "Welcome to the server")
        start_new_thread(self.mainFunc, (c, ))

    # waits for a message from the client and return the message
    def getMessage(self, c):
        message = c.recv(1024).decode()
        # decryption
        msg = aes256.decrypt(message, self.getKey()).decode()
        print(msg, "g")
        return msg
    
    # send a message to the client
    def sendMessage(self, c,  message):
        # encryption
        print(message, "s")
        encrypted = aes256.encrypt(message, self.getKey())
        print(encrypted)
        c.send(encrypted)
    
    def getResponse(self, method="", args=""):
        s.acquire()
        requestedUrl = f"{url}{method}?{args}"
        s.release()
        return requests.get(requestedUrl).text

    def recieve(self, c):
        self.sendMessage(c, "you can send me now")
        msg = self.getMessage(c)
        return msg

    def send(self, c, msg):
        self.sendMessage(c, msg)
        response = self.getMessage(c)
        
    def mainFunc(self, c):
        while True:
            msg = self.recieve(c)
            if msg == "0":
                self.signUp(c)
            elif msg == "1":
                print("hi")
                self.auth(c)
            elif msg == "2":
                self.active(c)
            elif msg == "3":
                self.sendChat(c)
            elif msg == "4":
                self.updateChats(c)
            elif msg == "5":
                self.getallemployees(c)
            elif msg == "6":
                self.updateChats(c)
            elif msg == "7":
                self.getlastacess(c)
            elif msg == "exit":
                self.endConnection(c)
                break
            else:
                print("not valid")

    # functions for application (authintication, signing up, who is active, sending messages (1-1, 1-M), super user) 
    def auth(self, c):
        username = self.recieve(c)
        password = self.recieve(c)
        args = f"username={username}&password={password}"
        response = self.getResponse("auth", args)
        if "True" in response:
            self.send(c, "Loggin in")
            self.getResponse("updateaccesstime", f"username={username}")
            active_users.append(username)
        else:
            self.send(c, "wrong")

    def signUp(self, c):
        username = self.recieve(c)
        password = self.recieve(c)
        response = self.getResponse("signup", f"username={username}&password={password}")
        if "True" in response:
            self.send(c, "you are in")
        else:
            self.send(c, "stay away from me you are a hacker")

    def sendChat(self, c):
        msg = self.recieve(c)
        reciver = self.recieve(c)
        sender = self.recieve(c)
        response = self.getResponse("sendchat", f"sender={sender}&reciever={reciver}&msg={msg}")[3:-4].split(",")


    def updateChats(self, c):
        sender = self.recieve(c)
        reciever = self.recieve(c)
        response = self.getResponse("getchat", f"sender={sender}&reciever={reciever}")[3:-4]
        results = list(eval(response))
        for msg in results:
            self.send(c, msg['MessageSent'])
            self.send(c, str(msg['Senderid'])) 
            self.send(c, str(msg['Recieverid']))
        self.send(c, "END")      

    def active(self, c):
        a = []
        for u in active_users:
            inx = u.find("@")
            if inx > -1:
                a.append(u[:inx])
            else:
                a.append(u)
        users = ",".join(a)
        self.send(c, users)

    def endConnection(self, c):
        username = self.recieve(c)
        if username in active_users:
            active_users.remove(username)
        self.getResponse("updateaccesstime", f"username={username}")
        c.close()

    def getlastacess(self, c):
        response = self.getResponse("checkaccesstime", "")[3:-4]
        results = list(eval(response))
        for msg in results:
            self.send(c, msg["Eemail"])
            time = str(msg["ElastAcess"])
            print(time)
            print(type(time))
            self.send(c, time)
        self.send(c, "END")

    # encryption/decryption
    def getKey(self):
        return "b14ca5898a4e4133bbce2ea2315a1916"

    

# create and starts the server class
def main():
    s = Server(777)
    s.startListening()


main()


#decMessage = rsa.decrypt(encMessage, privateKey).decode()
# encrypting message from server to client"""""