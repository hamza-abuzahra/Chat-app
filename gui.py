from logging import PlaceHolder
from tkinter import *
from tkinter import ttk

from numpy import column_stack


class App(Frame):
    def __init__(self, parent):
        Frame.__init__(self, parent)
        self.login()

    def login(self):
        for i in self.master.winfo_children():
            i.destroy()
        label = Label(self.master, text="Login", font=('', 25, 'bold'))
        label.grid(column=0, row=0, columnspan=5, pady=30, sticky=W+E) 
        unlbl = Label(self.master, text="Username", font=('', 12))
        unlbl.grid(column=0, row=1, columnspan=2, pady=20, sticky=W, rowspan=1)
        unentry = Entry(self.master, font=('', 12))
        unentry.grid(column=2, row=1, columnspan=3, sticky=E+W, pady=2)
        passlbl = Label(self.master, text="Password", font=('', 12))
        passlbl.grid(column=0, row=3, columnspan=2, pady=20, sticky=W, rowspan=1)
        passentry = Entry(self.master, font=('', 12), show="*")
        passentry.grid(column=2, row=3, columnspan=3, sticky=E+W, pady=2)
        loginbtn = Button(self.master, text="Login")
        loginbtn.grid(column=2, row=5, pady=15, columnspan=1, sticky=W)
        signupbtn = Button(self.master, text="Don't have an account?", command=self.signup)
        signupbtn.grid(column=3, row=5, pady=15, columnspan=1, sticky=E)
        for i in self.master.winfo_children():
            i.configure(background="#2e2d2d")
            i.configure(fg="#d4d2d2")
    
    def signup(self):
        for i in self.master.winfo_children():
            i.destroy()
        label = Label(self.master, text="Sign Up", font=('', 25, 'bold'))
        label.grid(column=0, row=0, columnspan=5, pady=30, sticky=W+E) 
        unlbl = Label(self.master, text="Username", font=('', 12))
        unlbl.grid(column=0, row=1, columnspan=2, pady=20, sticky=W, rowspan=1)
        unentry = Entry(self.master, font=('', 12))
        unentry.grid(column=2, row=1, columnspan=3, sticky=E+W, pady=2)
        passlbl = Label(self.master, text="Password", font=('', 12))
        passlbl.grid(column=0, row=3, columnspan=2, pady=20, sticky=W, rowspan=1)
        passentry = Entry(self.master, font=('', 12), show="*")
        passentry.grid(column=2, row=3, columnspan=3, sticky=E+W, pady=2)
        loginbtn = Button(self.master, text="Sign Up")
        loginbtn.grid(column=2, row=5, pady=15, columnspan=1, sticky=W)
        signupbtn = Button(self.master, text="Already have an account?", command=self.login)
        signupbtn.grid(column=3, row=5, pady=15, columnspan=1, sticky=E)
        for i in self.master.winfo_children():
            i.configure(background="#2e2d2d")
            i.configure(fg="#d4d2d2")

    def auth(self):
        pass

    def register(self):
        pass

    def mainGui(self):
        for i in self.master.winfo_children():
            i.destroy()






def main():
    root = Tk()
    root.title('Chat Client App')
    root.geometry("300x400+50+50")
    for i in range(5):
        # Grid.rowconfigure(root, i, weight=1)
        Grid.columnconfigure(root, i, weight=1)
    # Grid.rowconfigure(root, 3, weight=1)
    root.configure(bg="#2e2d2d")
    root.configure(padx=10)
    app = App(root)
    root.mainloop()


main()