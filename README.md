# thu-oculus-aiot-project

## Unity version
Unity version **2020.3.19f1**



## Running this project

1. Go inside Assets/, then `git clone https://github.com/VRSimulator/NUIX-Studio-APP`
2. Inside the newly cloned folder, replace `NUIX-Studio-APP/Environments/Environments/Living_Room.unity` with the one at the root directory
3. Open Unity Hub, add the root directory
4. Press play button when Unity is launched

Notes when deploying to Oculus: under **File → Build Settings**, ensure that the scene **Living_Room** has a designated index of 0.



## Developing

1. `git pull` to get the latest version of `Living_Room.unity` and `Living_Room.unity.meta`
2. Start developing, in the process you will change the file `Living_Room.unity` (and `Living_Room.unity.meta`) under the directory `/Assets/NUIX-Studio-APP/Environments/Environments/`
3. Replace the file `Living_Room.unity` at the root directory when you are done!
4. Commit your files and git push, notify in WeChat group



## Voice Commands

| Command            | Feature                            |
| ------------------ | ---------------------------------- |
| "(Wash/Dry) Open"  | Open the washing/drying machine    |
| "(Wash/Dry) Close" | Close the washing/drying machine   |
| "Start"            | Start the machine                  |
| "Stop"             | Stop the machine                   |
| "Mode Regular"     | Set the parameters to regular mode |
| "Mode Jacket"      | Set the parameters to jacket mode  |
| "Mode Shoes"       | Set the parameters to shoe mode    |

