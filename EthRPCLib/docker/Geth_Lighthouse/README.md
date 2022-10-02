# Instructions for Geth + Lighthouse
## Ethereum proof-of-stake

### Update settings [docker-compose.yml]
``` shell
[Insert IP, docker host does not resolve correctly]
```
Replace with your local ip address

### Linux
```shell
	chmod +x gen_jwt.sh 
	./gen_jwt.sh
	docker-compose up
```

### Windows
```shell
	Right click on gen_jwt.ps1
	Select "Run with PowerShell"
	From a prompt docker-compose up
```