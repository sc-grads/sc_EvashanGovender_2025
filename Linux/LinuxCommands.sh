#!/bin/bash

# Basic Navigation  
ls                  # List files/dirs  
ls -lh              # List with human-readable sizes + details  
ls -a               # Show hidden files (starting with '.')  
cd                  # Change directory
cd ~                # Go to home directory  
cd -                # Go back to the previous directory  
pwd                 # Print current directory path  

# File Manipulation  
mkdir               # Create directory
touch file.txt      # Create empty file (or update timestamp)  
cp file.txt /backup # Copy file to /backup  
cp -r dir1 dir2     # Copy directory recursively  
mv old.txt new.txt  # Rename file (or move to another location)  
rm file.txt         # Delete file  
rm -rf dir/         # Force-delete directory & contents (DANGEROUS!)  

# Viewing Files  
cat file.txt        # Print entire file  
less file.txt       # Interactive file viewer (scroll with arrows)  
more filte.txt      # View files page by page
head -n 5 file.txt  # Show first 5 lines  
tail -n 5 file.txt  # Show last 5 lines  
tail -f log.txt     # Follow log file in real-time  

# Searching Files  
find /home -name "*.pdf"  # Find PDFs in /home  
grep "error" log.txt      # Search for "error" in file  
grep -r "TODO" ~/projects # Recursively search for "TODO"  
locate filename           # Find file using pre-built database (run `updatedb` first)

#Permissions
chmod 755 <file>  # Set permissions: user=rwx, group/others=rx
chown user:group <file> # Change owner and group
chgrp group <file> # Change group ownership only

#System info
uname -a     # Show all system/kernel info
df -h        # Disk space free (human-readable)
free -h      # Memory/RAM usage (human-readable)
top          # Live system process monitor (q to quit)
htop         # Interactive process viewer (if installed)
ps aux       # List all running processes
uptime       # Show system uptime and load average

#Networking
ping <host>  # Check connectivity to a host
ifconfig     # Show network interfaces (deprecated, use `ip a`)
ip a         # Modern alternative to ifconfig
netstat -tuln # List active ports and services
ssh user@host # Connect to remote host via SSH
scp <file> user@host:/path # Secure copy file to remote host

#Package Management
sudo apt update     # Refresh package lists
sudo apt upgrade   # Upgrade installed packages
sudo apt install <pkg> # Install a package
sudo apt remove <pkg>  # Remove a package

#Process Control
kill <PID>          # Terminate process by ID
kill -9 <PID>       # Forcefully kill a process
pkill <name>        # Kill process by name
bg                  # Resume suspended job in background
fg                  # Bring background job to foreground

