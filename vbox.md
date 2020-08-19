* 윈도우에서 
cd c:\Program Files\Oracle\VirtualBox\
vboxmanage modifyhd c:\경로\docker.vdi --resize 30000


* 라이브시디로 확장
https://gparted.org/download.php

* VM시작
https://www.linuxtechi.com/extend-lvm-partitions/

sudo vgdisplay
df -H
sudo  lvextend -L 100%FREE /dev/mapper/ubuntu--vg-ubunt--lv
sudo  resize2fs /dev/mapper/dev/mapper/ubuntu--vg-ubunt--lv
