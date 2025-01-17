# Cal-RIPA STOP Debugger

## STOP Data Debugger

RIPA has a hidden gem that lets you see the Json data objects as you progress thru a STOP entry event. You can configure RIPA to display a hidden button at the bottom of the STOP entry form by following the instructions below. Once the debugger has been configured you can find the link/button.

The biggest value of this feature is that you can use the "RIPA STOP" data element as a template for predefined templates. For example you can create a "Motor Traffic" or "Probation Contact" template to simplify users data entry process. See the in structions for [STOP Templates](STOP-TEMPLATES.md) to create the templates you need.

Follow the [application configuration](./APP-CONFIG.md) instruction to edit the config.json file and turn on the STOP Data Debugger. When editing this file be sure to set the "DisplayDebugger" property to the desired value of "true" or "false".

| ![RIPA STOP Data Debugger](./assets/RIPA-STOP-Data-Debugger-01.png) |
| ------------------------------------------------------------------- |

### What do I see?

The STOP Data Debugger has 3 sections (tabs). The "RIPA FULL STOP" tab shows the json data that is used internally to the UI. This json structure never leaves the UI as it is translated to the "API STOP" json object before being sent to the backend STOP API. The "API STOP" is as it sounds the contract between the user interface and the STOP Azure Function APIs. The "RIPA STOP" is the base template used to instantiate the RIPA FULL STOP object. This could be the "Basic STOP" that all RIPA applications have

### API STOP

| ![API STOP](./assets/RIPA-STOP-Data-Debugger-02.png) |
|-

### RIPA FULL STOP

| ![RIPA FULL STOP](./assets/RIPA-STOP-Data-Debugger-03.png) |
|-

### RIPA STOP

| ![RIPA STOP](./assets/RIPA-STOP-Data-Debugger-04.png) |
|-
