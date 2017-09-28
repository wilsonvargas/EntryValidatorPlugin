# Entry Validator Control Plugin for Xamarin.Forms

Simple but elegant way of validate what your users write in your Xamarin.Forms projects. 

#### Setup
* Install into your PCL project and Client projects.

### Android
You do not need to initialize this component.

<img alt="android" src="http://l7c.us/descargas/images/android.png" 
data-canonical-src="http://l7c.us/descargas/images/android.png"
 width="250" height="480" />


### iOS
You do not need to initialize this component.


<img alt="ios" src="http://l7c.us/descargas/images/android.png" 
data-canonical-src="http://l7c.us/descargas/images/android.png"
 width="250" height="480" />


### UWP
You do not need to initialize this component.

<img alt="android" src="http://l7c.us/descargas/images/android.png" 
data-canonical-src="http://l7c.us/descargas/images/android.png"
 width="250" height="480" />


**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 7+|
|Xamarin.Android|Yes|API 14+|
|Windows Phone Silverlight|No|
|Windows Phone RT|Yes|
|Windows Store RT|Yes|
|Windows 10 UWP|Yes|Build 10240+|
|Xamarin.Mac|No||

#### Usage
Instead of using an Entry simply use a ValidatorEntry instead!

You **MUST** set the Length value if your control is a LenghtValidator. 
You can also:
Change color of error message and customize its content.
Change placeholder.
Choose if success icon is displayed.
Choose if error message is displayed.

Here is a sample:
```
new LengthValidator
{
  PlaceHolder = "Enter number of credit card",
  Lenght = 16,
  ErrorMessageColor = Color.Black,
  ShowIcon = true,
  ShowMessageError = true
}
```

**XAML:**

First add the xmlns namespace:
```xml
xmlns:validator="clr-namespace:EntryValidator.FormsPlugin.Abstractions;assembly=EntryValidator.FormsPlugin.Abstractions"
```

Then add the xaml:

```xml
<validator:LengthValidator 
       x:Name="length" 
       ErrorMessageColor="Black" 
       ShowIcon="True" 
       ShowMessageError="True"  
       PlaceHolder="Enter number of credit card" 
       VerticalOptions="CenterAndExpand" 
       Length="16"/>
```

#### License
Licensed under MIT, see license file
