# OrgBook App
This app verifies if a specified OrgID (BC Registered Organization ID).  This is a standalone app that returns HTML and does not interact with the Dynamics database

### Running App Locally
```bash
cd app
npm i
npm run local
```

### Running Image Locally
You must have podman or docker installed in your WSL2 instance.  Podman is preferred but if you're one of the few left still using docker, just make a bash alias: `podman=docker` and you're good to go.

Run the `local.sh` script to build and run this app locally
```bash
./local.sh
```

### Verify heartbeat endpoint
```bash
curl localhost:8080/version
```

### Verify / Debug Image
If you think something is not working you can verify the image by starting it with a shell instead of the default entrypoint.
```bash
podman run -it --rm  --entrypoint=sh orgbook-app
ls -al
env
npm run local
exit
```
