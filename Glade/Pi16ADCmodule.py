import time
import smbus
import sys
#import os, commands
import subprocess

from smbus import SMBus
from sys import exit

def openPi16ADC():
    bus = SMBus(1)
    address =  0b1110110
    channel0        =     0xB0
    channel1        =     0xB8
    channel2        =     0xB1
    channel3        =     0xB9
    channel4        =     0xB2
    channel5        =     0xBA
    channel6        =     0xB3
    channel7        =     0xBB
    channel8        =     0xB4
    channel9        =     0xBC
    channel10       =     0xB5
    channel11       =     0xBD
    channel12       =     0xB6
    channel13       =     0xBE
    channel14       =     0xB7
    channel15       =     0xBF
    vref = 2.5
    ch0_mult = 1 
    Ch0Value = ch0_mult*getreading(address, channel0)
    print ("Channel 0 at %s is %12.2f" % (time.ctime(), Ch0Value))
    return Ch0Value
def getreading(adc_address,adc_channel):
    bus = SMBus(1)
    vref = 2.5
#####################################################################################

# To calculate the voltage, the number read in is 3 bytes. The first bit is ignored. 
# Max reading is 2^23 or 8,388,608
#

    max_reading = 8388608.0

# Now we determine the operating parameters.
# lange = number of bytes to read. A minimum of 3 bytes are read in. In this sample we read in 6 bytes,
# ignoring the last 3 bytes.
# zeit (German for time) - tells how frequently you want the readings to be read from the ADC. Define the
# time to sleep between the readings.
# tiempo (Spanish - noun - for time) shows how frequently each channel is read in over the I2C bus. Best to use
# timepo between each successive readings.
#
#

    lange = 0x06 # number of bytes to read in the block
    zeit = 5     # number of seconds to sleep between each measurement
    tiempo = 0.4 # number of seconds to sleep between each channel reading
    bus.write_byte(adc_address, adc_channel)
    time.sleep(tiempo)
    reading  = bus.read_i2c_block_data(adc_address, adc_channel, lange)
#----------- Start conversion for the Channel Data ----------
    valor = ((((reading[0]&0x3F))<<16))+((reading[1]<<8))+(((reading[2]&0xE0)))
# Debug statements provide additional prinout information for debuggin purposes. You can leave those commented out.
# Debug
#       print("Valor is 0x%x" % valor)
#----------- End of conversion of the Channel ----------
    volts = valor*vref/max_reading
    return volts
