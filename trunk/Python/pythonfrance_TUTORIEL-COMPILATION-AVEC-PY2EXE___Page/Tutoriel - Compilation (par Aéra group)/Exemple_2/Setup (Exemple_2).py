from distutils.core import setup
import py2exe


setup(windows=[{"script": "Exemple_2.py",  "icon_resources": [(1, "py.ico")]}],
     options = {"py2exe":
                    {"compressed": 2,
                        "optimize": 1}})
