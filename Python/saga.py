#IPv6 LCSP Secret Address Generation Algorithm

import sys
import string
import hashlib
import ipaddr
from netaddr import *
import pprint
#import myFirstForm
from time import gmtime, strftime


#Current IPv6 address and session key. Later fetch these values from application database.
selfAddress = '3ffe:1900:4545:0003:0200:f8ff:fe21:67cf'
selfKey = 'mypassword123'
peerAddress = ' '
peerKey = ' '
currentTime = strftime("%H%M")

#Print current IPv6 address. Fetch from data
#txtCurrentIPv6
#Might replace this with system time later
print('Current Address: ' + selfAddress)


#Convert current address to string
ip = IPAddress(0, 6)
ip = IPNetwork(selfAddress)
#Convert the IP address to a hex string. Remove delimiters, basically.
selfAddressToHex = hex(ip.ip)
#Remove the '0x' characters from string.
selfAddressString = selfAddressToHex[2:]
print('Current Address String: ' + selfAddressString)

print('Current Time: ' + currentTime)

#Generate SHA256 fingerprint for the current time and session key
hashInput = (selfKey + currentTime)
print('Hash Input: ' + hashInput)
hashedValue = hashlib.sha256(hashInput)
hashedValueString = (hashedValue).hexdigest()
print('SHA256 Fingerprint: ' + hashedValueString)


#Get the last eight bytes of the SHA256 fingerprint to use as new interface address
final32 = hashedValueString[56:64]
print('New Suffix: ' + final32)


#Subsitute last eight bytes of current address with the last eight bytes of the SHA256 fingerprint
newAddressString = selfAddressString.replace(selfAddressString[24:32], final32)
print('New Address String: ' + newAddressString)


# Convert new address string to IPv6 address
newAddress = ':'.join([newAddressString[i:i+4] for i in range(0, len(newAddressString), 4)])
print('New Address: ' + newAddress)
