#! /usr/bin/bash
sudo systemctl stop hello-service
sudo systemctl disable hello-service
sudo rm /etc/systemd/system/hello-service.service
sudo journalctl --rotate
sudo journalctl --vacuum-time=1s