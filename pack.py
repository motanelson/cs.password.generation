import os
import copy
print("\033c\033[47;30m\ngive me the .txt pack file ? \n")
a=input().strip()
names=a.replace(".txt","")
f1=open(a,"r")
f=f1.read()
f1.close()
ff=f.split("\n")
counter=0
f1=open(names+".bjava","wb")
f1.write(b"JAVA")
f1.close()

for d in ff:
    if  d.strip()!="":
        f1=open(names+".bjava","ba")
        f1.write(b"\x01\x00\x05\x04\x03\x02")
        f1.write(ff[counter].encode())
        f1.write(b"\x00")
        f1.close()
    counter=counter+1
