# Entry Validator Control Plugin for Xamarin.Forms
Simple but secure way of display Entries validators in your Xamarin.Forms projects. 

**Platform Support**
|Platform|Supported|Version|| ------------------- | :-----------: | :------------------: ||Xamarin.iOS|Yes|iOS 7+||Xamarin.Android|Yes|API 14+||Windows Phone Silverlight|No||Windows Phone RT|No||Windows Store RT|Yes||Windows 10 UWP|Yes||Xamarin.Mac|No||

#### Usage Instead of using an Entry simply use a EmailValidator instead!

You **MUST** set the width & height requests to the same value. Here is a sample:

```new EmailValidator{  PlaceHolder = "Enter an email",  ShowMessageError = true,  ErrorMessageColor = Color.Red, Keyboard= Keyboard.Email```

**XAML:**
First add the xmlns namespace: ```xmlxmlns:local="clr-namespace:ButtonCircle.FormsPlugin.Abstractions;assembly=ButtonCircle.FormsPlugin.Abstractions"```
Then add the xaml:
```xml
<StackLayout Orientation="Vertical" VerticalOptions="CenterAndExpand" HorizontalOptions="FillAndExpand">        <validator:EmailValidator x:Name="email" VerticalOptions="CenterAndExpand" Keyboard="Email" ShowMessageError="True" ErrorMessageColor="Red"/>        <validator:LengthValidator x:Name="length" ErrorMessageColor="Black"  PlaceHolder="Enter number of credit card" VerticalOptions="CenterAndExpand" Length="16"/>        <validator:CompareValidator VerticalOptions="CenterAndExpand"/>        <Button Text="Register" Clicked="Button_Clicked" />    </StackLayout>
```
