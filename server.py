from argparse import ArgumentError
from ast import Try
from urllib import response
import requests
import socket as sk
import time
from datetime import date
from _thread import *
from Crypto import Random
from Crypto.PublicKey import RSA
import Crypto


url = "http://127.0.0.1:5000/"

active_users = ["me"]


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
        while True:
            self.accept_connections()

    def accept_connections(self):
        c, self.address = self.socket.accept()
        print("connected successfully")
        # ask the client for its public key::
 
        self.sendMessage(c, "Welcome to the server ")
        start_new_thread(self.mainFunc, (c, ))

    # waits for a message from the client and return the message
    def getMessage(self, c):
        message = c.recv(1024).decode()
        decryptedMessage = decryptedMessage(message)
        print(message)
        return message
    
    # send a message to the client
    def sendMessage(self, c,  message):
        encryptedMessage =  encryptMessage(message)
        c.send(encryptedMessage.encode())
    
    def getResponse(self, method="", args=""):
        requestedUrl = f"{url}{method}?{args}"
        return requests.get(requestedUrl).text

 

    def mainFunc(self, c):
        while True:
            msg = self.getMessage(c)
            if msg == "0":
                self.signUp(c)
            elif msg == "1":
                self.auth(c)
            elif msg == "2":
                self.active(c)
            elif msg == "3":
                self.sendChat(c)
            elif msg == "exit":
                self.endConnection(c)
                break

    # functions for application (authintication, signing up, who is active, sending messages (1-1, 1-M), super user) 
    def auth(self, c):
        username = self.getMessage(c)
        password = self.getMessage(c)
        args = f"username={username}&password={password}"
        response = self.getResponse("auth", args)
        if "True" in response:
            print("l")
            self.sendMessage(c, "Loggin in")
            active_users.append(username)
        else:
            self.sendMessage("wrong")

    def signUp(self, c):
        username = self.getMessage(c)
        password = self.getMessage(c)
        response = self.getResponse("signup", f"username={username}&password={password}")
        if "True" in response:
            print("i")
            self.sendMessage(c, "you are in")
        else:
            self.sendMessage(c, "stay away from me you are a hacker")

    def sendChat(self):
        pass
    
    def active(self, c):
        users = ",".join(active_users)
        print(active_users)
        self.sendMessage(c, users)      

    def endConnection(self, c):
        username = self.getMessage(c)
        active_users.remove(username)
        c.close()

    def getKey(self):
        key = "b14ca5898a4e4133bbce2ea2315a1916"

    def encryptMessage(self, text):
        key = getKey
        plain_text = pad(plain_text)
        print("After padding:", plain_text)
        iv = Random.new().read(AES.block_size)
        cipher = AES.new(key, AES.MODE_CBC, iv)
        return base64.b64encode(iv + cipher.encrypt(plain_text))


    def decrypt(self, text):
        key = getKey
        cipher_text = base64.b64decode(text)
        iv = text[:16]
        cipher = AES.new(key, AES.MODE_CBC, iv)
        return unpad(cipher.decrypt(cipher_text[16:]))

# create and starts the server class
def main():
    s = Server(777)
    s.startListening()


main()


#decMessage = rsa.decrypt(encMessage, privateKey).decode()
# encrypting message from server to client"""""