# NigeriaFinance
> NuGet package tailored for acquiring banks and pension fund data, ensuring sensitive information remains externalized and secure, aligning with best practices for app development.


## Built With

- Major languages: C#
- Frameworks: .NET Standard 2.0
- Technologies: Github and Visual Studio

# Frameworks Version Support
- **.NET and .NET Core** 2.0, 2.1, 2.2, 3.0, 3.1, 5.0, 6.0, 7.0, 8.0
- **.NET Framework**     4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8, 4.8.1

## Getting Started

  - To install our package using the .NET CLI: 
  ```C#
  dotnet add package NigeriaFinance --version 1.0.0
  ```
  - Installation using Visual Studio
    - Right-click on project dependencies
    - Select manage Nuget packages
    - Search `NigeriaFinance`
    - Click install

  - Installation using .NET Package Manager Console
  ```C#
    PM> Install-Package NigeriaFinance -Version 1.0.0
  ```
  - Finally, import into file
  ```C#
    using NigeriaFinance;
  ```
### Prerequisites
  - An understanding of C# and NuGet Packages
  - A Visual Studio

### Usage

```C#
await NgFinance.GetInstitutesAsync(typeId);
```
- Input

| Parameter | Type  | Description                                          |
|:----------|:------|:-----------------------------------------------------|
| `typeId`  | `enum`| **Required**: The ID of type of institution to fetch |

- Output

| Type                                   |
|:---------------------------------------|
| `Task<IEnumerable<InstituteResponse>>` |

<Br>

---

```C#
await NgFinance.GetInstituteAsync(typeId, instituteId);
```
- Input

| Parameter     | Type      | Description                                             |
|:--------------|:----------|:--------------------------------------------------------|
| `typeId`      | `enum`    | **Required**: The ID of type of institution to fetch    |
| `InstituteId` | `int`     | **Required**: The ID of the institute to get            |  
- Output

| Type                      |
|:--------------------------| 
| `Task<InstituteResponse>` |


## Authors

👤 **Joshua Eze**

- GitHub: [@Allenkeys](https://github.com/Allenkeys)
- Twitter: [@jdgraay](https://twitter.com/jdgraay)
- LinkedIn: [Eze Joshua](https://linkedin.com/in/eze-joshua-chinemogo)


## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

Feel free to check the [issues page](https://github.com/allenkeys/NigeriaFinance/issues).


## Show your support

Give a ⭐️ if you like this project!

## 📝 License

This project is [MIT](./LICENSE) licensed.
