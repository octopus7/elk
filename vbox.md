https://www.linuxtechi.com/extend-lvm-partitions/



sudo vgdisplay
df -H

sudo  lvextend -L 100%FREE /dev/mapper/ubuntu--vg-ubunt--lv

sudo  resize2fs /dev/mapper/dev/mapper/ubuntu--vg-ubunt--lv

