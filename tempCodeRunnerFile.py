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
        cipher = AES.new(key, AES.MODE