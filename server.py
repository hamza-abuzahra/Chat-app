from argparse import ArgumentError
from urllib import response
import requests
import socket as sk
import time
from datetime import date

url = "http://127.0.0.1:5000/"



class Server():
    # constructor creates the socket object 
    def __init__(self, port):
        self.socket = sk.socket(sk.AF_INET, sk.SOCK_STREAM)
        print("socket created successfully")
        self.port = port

    # start listening for a client to connect, and then calls auth function 
    # to check the login information of the client
    def startListening(self):
        host = sk.gethostname()
        self.socket.bind(('localhost', self.port))
        print(host)
        print("socket bind is done")
        self.socket.listen(5)
        print("socket is listening")
        self.c, self.addr = self.socket.accept()
        print("connected successfully")
        self.sendMessage("Welcome to the server")
        self.mainFunc()
    
    # waits for a message from the client and return the message
    def getMessage(self):
        message = self.c.recv(1024).decode()
        return message
    
    # send a message to the client
    def sendMessage(self, message):
        self.c.send(message.encode())
    
    def getResponse(self, method="", args=""):
        requestedUrl = f"{url}{method}?{args}"
        return requests.get(requestedUrl).text

    def mainFunc(self):
        while True:
            msg = self.getMessage()
            if msg == "0":
                self.signUp()
            elif msg == "1":
                self.auth()

    # functions for application (authintication, signing up, who is active, sending messages (1-1, 1-M), super user) 
    def auth(self):
        username = self.getMessage()
        password = self.getMessage()
        args = f"username={username}&password={password}"
        response = self.getResponse("auth", args)
        if "True" in response:
            print("l")
            self.sendMessage("Loggin in")
        else:
            self.sendMessage("wrong")

    def signUp(self):
        username = self.getMessage()
        password = self.getMessage()
        response = self.getResponse("signup", f"username={username}&password={password}")
        print(response)
        if "True" in response:
            print("i")
            self.sendMessage("you are in")
        else:
            self.sendMessage("stay away from me you are a hacker")

    def sendChat(self):
        pass
    
    def active(self):
        pass

# create and starts the server class
def main():
    s = Server(777)
    s.startListening()


main()
