import glob
import os
import re
from distutils.core import setup
import py2exe


setup(windows=[{"script": "Exemple_2.py",
                "other_resources": [(u"VERSIONTAG",1, "1.0")],
                "icon_resources": [(1, "py.ico")]}],	
    
    description = "Logiciel test (par Aéra group).", 
    
    version = "1.0",
                  
    options = {"py2exe":
                    {   "compressed": 1,
                        "optimize": 2,
                        "excludes": ["_gtkagg", "_tkagg"],
                        "dll_excludes": ["libgdk-win32-2.0-0.dll",
                                         "libgobject-2.0-0.dll"]}})
