# Cache Utility
The CacheUtility module provides an easy way to assign runtime caches of data to ScriptableObjects.

Modifying member fields in a ScriptableObject during runtime has inconsistent behaviour. In the editor, the set fields remain the same between test runs. In a build, the set fields are reset at launch. By assigning a cache to them, the information is set when they are first called upon, once per launch or test run, and do not keep data between runs.

You'll probably only need to know how the AssetObject works. Check the documentation website, link found below, on how it works!

> When using this module, make sure to **Star** this repository. I would appreciate it if you gave credits to **Eric van Gastel** somewhere in your product, but I won't hold it against you if you don't. That said; **this module is not allowed to be sold anywhere!**

## Installation
There are two ways to install it, depending on your personal preference. By importing the Unity Package, or adding the Github Submodule.

### Unity Package
If you want to add the module by importing an UnityPackage, you can get the package from two sources:

You can simply download and import the **CacheUtility.unitypackage** into your Unity Project manually. (TODO: Add package release branch)

Or you can go to the CacheUtility Asset Store page and download it from there. (TODO: Add AssetStore page)

### Github Submodule
You can setup a submodule in your repository, making it easier to stay updated with the latest version.

Before adding the submodule, you should prepare a few project settings within Unity to accommodate the new files. As a side effect, this will make it safer for you to use Github for your Unity project.

Go to *Edit/Project Settings*, then to the *Editor* tab. Swap *Version Control Mode* to *Visible Meta Files*, and *Asset Serialization* to *Force Text*. This will ensure all objects and references are pushed in a safe way, avoiding complicated conflicts in prefabs and scenes or loss of asset references.

Use the command line below to install the submodule into your github project.
```
$ git submodule add https://github.com/DuskModules/CacheUtility Assets/DuskModules/1-UtilityModules/CacheUtility
```

## Demo & Documentation
There is an unity package available in the module folder called **DemoPackages.unitypackage**. Import the contents if you want to check out the demo scenes and examples of the module functionality. You can always delete the demo folders without causing conflicts or errors.

For more details on how to use the module, and what features it provides, check out the DuskModules website:
https://sites.google.com/dusklightstudios.com/duskmodules/utility-modules/cacheutility

&nbsp;

# DuskModules Framework
The DuskModules framework contains numerous modules, each providing a distinct feature for game development in Unity. Some modules are open-source, and shared on github by https://github.com/duskmodules. All modules are also available on the Asset Store, though some are exclusively available for a small price, and cannot be downloaded from Github.

The framework is organised by 4 distinct categories of modules:
- Utility, provides programmer and developer assisting scripts
- Tech, provides large technical features such as input or data handling
- Game, provides core gameplay mechanics and effects, such as health and weapon systems
- MetaGame, provides long-term progression game mechanics such as levels or achievements

## Full Module Info & Features
To see an overview of all available modules, their features, and on how to use them best, check out their documentation on the DuskModules website:
https://sites.google.com/dusklightstudios.com/duskmodules

### State of Development
A transparent development process shows everyone how certain improvements and new features are coming along, and allows other people to chip in their opinion and expertise, resulting in more useful software for everyone.

That's why you can view and comment on the development of the DuskModules here:
https://trello.com/b/NwA0rary/dusklight-framework

## Contact
Send me a mail at info@dusklightstudios.com if you have any questions about the use of the DuskModules.

### Feedback
I'd love to hear back from you if you're using a module. Let me know what you're working on, and where the modules might need some work. I'll do my best to improve it to make it the best of the best.

> If you are releasing or have released a project using any DuskModule, send me a message! I'll share your project on all social media I can reach to promote both our work.


