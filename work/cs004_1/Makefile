# Compiler flags

CS=csc
CSFLAGS= /nologo /warn:4 /lib:$(AssermblyFolder) *.lib /warnaserror+ /out:$(FILEOUT)

!ifdef DEBUG
CSFLAGS=$(CSFLAGS) /debug:full /optimize-
!else
CSFLAGS=$(CSFLAGS) /debug:pdbonly /optimize+

# Source directory
SOURCES=*.cs

# Final exe

FILEOUT=main.exe

# Targets

$(FILEOUT) : $(SOURCES)
  $(CS) $(CSFLAGS) $(SOURCES)
