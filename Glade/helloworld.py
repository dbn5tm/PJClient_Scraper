import gi
import Pi16ADCmodule

gi.require_version('Gtk', '3.0')
from gi.repository import Gtk

#class Handler:
#   def onDestroy(self, *args):
#        Gtk.main_quit()
#
#    def onButtonPressed(self, button):
#       print("Hello World!")
#        ch0 = Pi16ADCmodule.openPi16ADC()
#       print(ch0)
def readPi(readBtn):
    ch0 = Pi16ADCmodule.openPi16ADC()
    print(ch0)
    lblCh0.set_text(str(ch0))

handlers = {
    "onDestroy": Gtk.main_quit,
    "onButtonPressed": readPi
}        
        

builder = Gtk.Builder()
builder.add_from_file("RotatorControl.glade")
builder.connect_signals(handlers)

window = builder.get_object("mainwindow")
lblCh0 = builder.get_object("lblCh0")
window.show_all()

Gtk.main()
