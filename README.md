# FilepathAnalysis

![build](https://img.shields.io/github/actions/workflow/status/con-web-adipp/FilepathAnalysis/build.yml)
![release](https://img.shields.io/github/v/release/con-web-adipp/FilepathAnalysis)
![license](https://img.shields.io/github/license/con-web-adipp/FilepathAnalysis)

FilepathAnalysis is a Griffeye Analyze DI Pro plugin that performs an automated watch list search in the the filepath of any give file in Griffeye Analyze DI Pro.
If a search term has a match, a bookmark is attached to the respective file in Analyze DI Pro.

## First steps
### System requirements

- Win64
- [Griffeye Analyze DI Pro](https://www.griffeye.com/analyze-di/)



### Download and installation

The latest release is available for download on the [release page of this repository](https://github.com/con-web-adipp/FilepathAnalysis/releases).


Install the plugin by selecting ``FilepathAnalysis_[Version].appkg`` from ``File -> Settings -> Plugins -> Install`` within Griffeye Analyze DI Pro.

The plugin is ready to use immediately (e.g. via ``Case Data -> Rescan against Plugins -> FilepathAnalysis``).

## Basic usage

The plugin helps to automatically pre-sort the data in an Analyze DI Pro case, especially when analyzing smartphone data. 
On the one hand, system and program files that dont match with the NIST whitelist can be identified (e.g. if the search term "emoji" appears somewhere in the file path).
On the other hand, evaluating the filepath makes it possible to assign the files to specific applications (WhatsApp, Instagram, etc.).

The watch lists are stored in a .JSON file at the following file path:

```
C:\ProgramData\Griffeye Technologies\Griffeye Analyze\Data\Plugins\FilepathAnalysis\watchlist.json
```


The content of the file looks like this:
```json
[
  {
    "Name": "social_media",
    "SearchTerms": [
      "whatsapp",
      "viber",
      "instagram",
      "telegram",
      "signal",
      "threema",
      "facebook",
      "twitter",
      "snapchat",
      "tiktok",
      "musically"
    ]
  },
  {
    "Name": "software",
    "SearchTerms": [
      "\\.apk",
      "\\.bundle",
      "texture",
      "favicon",
      "emoji",
      "emoticon",
      "framework",
      "resource",
      "wallpaper",
      "thumbnails"
    ]
  }
]
```
The value for the key ```"Name"``` defines a name for a keyword list. This name will then appear in Analyze DI Pro as the parent category of all bookmarks assigned to the keywords in this list.
The list of values for the key ```"SearchTerms"``` defines the respective search terms.

The use of regular expressions is possible.

## See also

- [https://regex101.com/](https://regex101.com/) (build and test regular expressions)
- [https://www.griffeye.com/analyze-di/](https://www.griffeye.com/analyze-di/)
