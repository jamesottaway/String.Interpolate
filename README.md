# String.Interpolate

Interpolate your .NET strings

## About

This library leans heavily on the work of the following people:

- Phil Haack
- Scott Hanselman
- Henri Wiechers
- James Newton-King
- Oskar Austegard

The history of this code can be found on [You've Been Haacked][haacked]:

- [Fun With Named Formats, String Parsing, and Edge Cases][fun-with-named-formats]
- [Named Formats Redux][named-format-redux]

## Install

You can install `String.Interpolation` using NuGet:

```powershell
PM> Install-Package String.Interpolation
```

## Why?

The existing `String.Format` method, for example, formats values according to position.

```csharp
string s = string.Format("{0} first, {1} second", 3.14, DateTime.Now);
```

But what *I* wanted was to be able to use the name of properties/fields, rather than position like so:

```csharp
var args = new {pi = 3.14, date = DateTime.Now};
string s = "{pi} first, {date} second".Interpolate(args);
```

## License

[Creative Commons — Attribution 2.5 Generic — CC BY 2.5](https://creativecommons.org/licenses/by/2.5/)

You are free to:

  - **Share** - copy and redistribute the material in any medium or format
  - **Adapt** - remix, transform, and build upon the material

for any purpose, even commercially.

The licensor cannot revoke these freedoms as long as you follow the license terms.

[haacked]: http://haacked.com/
[fun-with-named-formats]: http://haacked.com/archive/2009/01/04/fun-with-named-formats-string-parsing-and-edge-cases.aspx/
[named-format-redux]: http://haacked.com/archive/2009/01/14/named-formats-redux.aspx/
