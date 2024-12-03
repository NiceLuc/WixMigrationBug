# Wix v4 Migration Bug

The `main` branch contains a very simple setup program that harvests `ClassLibrary1` and `ConsoleApp1` to a setup program.

* You can build the project.
* Running the `msi` file will install 3 files to the following directory:

![image](https://github.com/user-attachments/assets/329c62a2-9272-4ade-9a11-93a650224cab)

## Migrating to WiX v4...

1. Right click on the wix project and choose **Upgrade to WiX 4...**:
  - ![image](https://github.com/user-attachments/assets/ffcb3594-2c7d-4ff8-a5ca-98ea97f95f2a)
2. Should see that it generated no errors:
  - ![image](https://github.com/user-attachments/assets/6532e714-f4ff-4ec3-9619-99f3ce2282fd)
3. Scan logs for any errors or warnings...

Here is the log that was generated from the migration process:

```txt
[12/03/2024 12:58:54.355]: Converting project file SetupProject1.wixproj...
[12/03/2024 12:58:55.119]: Converting file: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs...
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs : information WIX0005: [Converted] This file contains an XML declaration on the first line. (DeclarationPresent)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs(1) : information WIX0009: [Converted] The namespace 'http://schemas.microsoft.com/wix/2006/wi' is out of date. It must be 'http://wixtoolset.org/schemas/v4/wxs'. (XmlnsValueWrong)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs(2) : information WIX0023: [Converted] Using '*' for the Product Id attribute is unnecessary. Remove the attribute to remove the redundancy. (AutoGuidUnnecessary)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs(2) : information WIX0032: [Converted] A MediaTemplate with no attributes set is now provided by default. Remove the element. (DefaultMediaTemplate)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs(2) : information WIX0030: [Converted] The Product and Package elements have been renamed and reorganized for simplicity. (ProductAndPackageRenamed)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs : information WIX0058: [Converted] The TARGETDIR directory should no longer be explicitly defined. Remove the Directory element with Id attribute 'TARGETDIR'. (TargetDirDeprecated)
[12/03/2024 12:58:55.143]: C:\dev\Nice\NiceLuc\WixMigrationBug\src\ConsoleApp1\SetupProject1\Product.wxs(14) : information WIX0059: [Converted] Standard directories such as 'ProgramFilesFolder' should no longer be defined using the Directory element. Use the StandardDirectory element instead. (DefiningStandardDirectoryDeprecated)
[12/03/2024 12:58:55.144]: ---- Project SetupProject1: Converted 1 files.
[12/03/2024 12:58:55.144]: ---- Total time: 00.807
[12/03/2024 12:58:55.144]: ========== Import complete:  0 errors, 0 warnings
```

4. Build the new project!
  - > **ERROR**:  The identifier 'WixComponentGroup:Product.Generated' could not be found. Ensure you have typed the reference correctly and that all the necessary inputs are provided to the linker.

## Repository  Branches
* See `migration-bug` branch for the results of the migration.
* See `migration-fix` branch for the required changes to fix it.
