# CustomMTFAnnouncement
A simple exiled plugin that changes the Cassie announcement when NTF spawned.

# Installation
Requires [Exiled 5.3.0+](https://github.com/Exiled-Team/EXILED/releases) for this plugin to work.
Simply place **CustomMTFAnnouncement.dll** into your Exiled plugins folder.

# Instructions
* {mtfunit} Replaces with the unit team like XRAY.
* {mtfnum} Replaces with the unit number like 02.
* {scpnum} Replaces with number of scps.

# Configs
```yml
# Whether or not the plugin is enabled.
  is_enabled: true
  # What should cassie say when there's no scp left.
  noscp_announcement: mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining noscpsleft
  # What should cassie say when there's one scp left.
  onescp_announcement: mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining awaitingrecontainment {scpnum} scpsubject
  # What should cassie say when there are more than 2 scps left.
  twoscps_announcement: mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining awaitingrecontainment {scpnum} scpsubjects
  ```
# Note
This plugin does not support subtitle feature, that means the subtitle for NTF announcement will not show up.
