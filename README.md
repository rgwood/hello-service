# Demo

```
sudo cp hello-service.service /etc/systemd/system/hello-service.service
sudo systemctl enable hello-service
sudo systemctl start hello-service
curl "http://localhost:5000/Hello?name=Reilly%20Wood"
systemctl status hello-service
sudo systemctl stop hello-service
```