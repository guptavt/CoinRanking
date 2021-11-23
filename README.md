ZIGLU Coinranking API

Setting up the project locally

1. Install Visual Studio 2019 or upper version suitable for your machine OS from https://visualstudio.microsoft.com/downloads/
3. Open Visual studio and map your GIT repo from following url: https://github.com/guptavt/CoinRanking 
4. Check that the solution has following Nuget packages. If not, you might benefit from 'Restore nuget packages' on the solution:
- BoDi v1.5.0
- Gherkin v19.0.3
- Newtonsoft.Json v12.0.3
- NUnit v3.13.1
- RestSharp v106.10.1
- SpecFlow v3.9.40
- SpecFlow.Internal.Json v1.0.8
- SpecFlow.NUnit v3.9.40 
- SpecFlow.Tools.MsBuild.Generation v3.9.40
- System.Reflecton.Emit v4.3.0
- System.Reflecton.Emit.Lightweight v4.3.0
- System.Threading.Tasks.Extension v4.4.0
- System.ValueTuple v4.4.0
- Utf8Json v1.3.7
5. Install dotnet framework v4.7.2
6. In app.config, replace %API_KEY with the actual key
7. From Main menu click on Test > Windows > Test Explorer.
8. From Main menu click on Build > Clean Solution.
9. From Main menu click on Build > Build Solution, Ones project is successfullt built, following 3 tests will appear in the Test explorer window:
- Test Name:	Get7DayHistoryForMultipleCoins
- Test Name:	GetMultipleCoinsDetails
- Test Name:	GetMultipleExchangesDetails
10. Click on Run All button in the Test Explorer.
11. Ones all test have passed, click on each test > Output.
12. Navigate to the Output window to validate the printed result for each test.

To see printed result without setting up the project locally, go to Action page in the git repository at https://github.com/guptavt/CoinRanking/actions and click on any green build followed by clicking on Test link.



