#Report Sharing

[[_TOC_]]

##Question

How do I enable basic report sharing?

##Answer

Basic report sharing allows users to decide if they want to share a report or keep it in their private sandbox. It also enables sharing reports in read-only mode which act as templates. This mode allows other users to load a report but not overwrite it. Report creators can find these features in the "Misc" tab of the report designer. In order to use basic report sharing, you will need to set the [[CurrentUserName|/API/CodeSamples/CurrentUserName]], [[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]], [[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]], and the [[SharedWithValues|/API/CodeSamples/SharedWithValues]] setting for your users. 

The CurrentUserName setting will enable all reports created by this user to take ownership of the reports. The CurrentUserRoles sets what other reports this user is allowed to see. If CurrentUserIsAdmin is true, then the user will have full access to all reports within his/her Tenant setting. The SharedWithValues property will  set the values in the **Shared With** dropdown on the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.1-Share-With-&-Rights]] of the Report Designer. These can be usernames or role names.