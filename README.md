[logo]: https://raw.githubusercontent.com/Geeksltd/Zebble.IconButton/master/Shared/NuGet/Icon.png "Zebble.IconButton"


## Zebble.IconButton

![logo]

A Zebble plugin that allows you to add Icon Buttons in your application.


[![NuGet](https://img.shields.io/nuget/v/Zebble.IconButton.svg?label=NuGet)](https://www.nuget.org/packages/Zebble.IconButton/)

> Icon button is a shortcut to get a button that has an Image and text. The Image can be on the left side or right side of the Text.
You only need to set IconPath and Text for that

<br>


### Setup
* Available on NuGet: [https://www.nuget.org/packages/Zebble.IconButton/](https://www.nuget.org/packages/Zebble.IconButton/)
* Install in your platform client projects.
* Available for iOS, Android and UWP.
<br>


### Api Usage

#### MarkUp:
```xml
<IconButton Id="SaveButton" IconPath="Images/Controls/Check.png" Text="Save" IconLocation="Left" on-Tapped="SaveButtonTapped" />
```
You can also change the icon at runtime using the following:
```csharp
SaveButton.AddIcon("Images/Controls/Check.png");
```
Compared to using a Stack to achieve the same layout, this control is shorter and briefer to write, but also more semantic and readable. Also, it's easier to style in Css.

### Properties
| Property     | Type         | Android | iOS | Windows |
| :----------- | :----------- | :------ | :-- | :------ |
| IconPath            | string           | x       | x   | x       |
| IconLocation            | IconLocation           | x       | x   | x       |

### Methods
| Method       | Return Type  | Parameters                          | Android | iOS | Windows |
| :----------- | :----------- | :-----------                        | :------ | :-- | :------ |
| AddIcon         | Task| -| x       | x   | x       |
