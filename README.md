# Demo

```
sudo ln -s /home/reilly/source/hello-service/hello-service.service /etc/systemd/system/hello-service.service
sudo systemctl enable hello-service
sudo systemctl start hello-service
curl "http://localhost:5000/Hello?name=Reilly%20Wood"
systemctl status hello-service
sudo systemctl stop hello-service
```

# Cleanup
```
sudo systemctl disable hello-service
sudo journalctl --rotate
sudo journalctl --vacuum-time=1s
```