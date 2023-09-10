# CMPG-323-Project-2-38205742
_The EcoPower Logistics API empowers users with the capability to engage in a wide range of functions concerning customer management, order management, and product management. Built on the principles of the Representational State Transfer (REST) architectural style, the API seamlessly employs HTTP methods to seamlessly interact with the data source. By strictly adhering to the CRUD principles, the API offers users the ability to effortlessly generate, retrieve, modify, and eliminate records within the database.._
## Links
### Link to API on Azure:
[WebApi](https://p2-webapi.azurewebsites.net/index.html) 
### Link to Resource Group on Azure:
[rgP2API](https://portal.azure.com/#@nwuac.onmicrosoft.com/resource/subscriptions/ae904fbb-19de-40d3-8dba-264680e542a8/resourceGroups/rgP2API/overview)

## User Manual
1. Register user or admin with the 'Authenticate' endpoint.
2. Login with the user or admin.
3. Copy the token - make sure to copy 'Bearer' before the token for it to work correctly.
4. Click on Authorize and paste the token.
5. You can now use the Api Endpoints.

## Endpoints & Reports
_I have only showed the Get method, but the other methods works aswell._
### Authenticate
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/b56241c1-9c35-4804-a14d-da15df651704)
#### Copy Token
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/9a0ece4c-c858-4d22-859c-a1455aabdffe)
#### Paste Token
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/fa1b76a8-567c-44cc-85fb-61db69c1afb9)


### Customers
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/8903a194-edba-4410-b394-772d68be56e7)
#### GET (Get list of all Customers)
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/c2120a4a-2fa0-461a-9245-307932b30016)


### Orders
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/c7a956a3-68f1-4e95-8665-4bae267e6023)
#### GET (Get list of all Orders)
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/315e94d2-fbad-43a2-8ecf-0d36de4e28c2)


### OrdersDetails
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/605ef112-5da5-422e-b4fb-a8cb8e928fd3)
#### GET (Get list of Products from an Order Id)
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/05514600-da39-4cdf-8b90-6dd76ce1c54a)
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/ef5835c5-cd88-4f10-a4dc-dd49381cb3c0)


### Products
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/6f476651-5c42-42c1-a1e9-ed5c35e5b4c7)
#### GET (Get list of all Orders)
![image](https://github.com/Albert-Willemse/CMPG-323-Project-2-38205742/assets/112475881/bb922aee-df5b-45b6-b733-683d8597a163)

## Reference List

1. Azheer, N. 2019. _Api management consumption tier_ https://www.youtube.com/watch?v=6ldNyifH-Ko Date of access: 2023/08/30.
2. Emily. 2022. _How to add a .Gitignore file to visual studio 2022._ https://www.brainstormcreative.co.uk/git/how-to-add-gitignore-file-to-visual-studio-2022/#:~:text=gitignore%20file%20in%20Visual%20Studio,Git%20%3E%20Settings%20as%20shown%20below.&text=That%20will%20open%20the%20gitignore,pre%2Dpopulated%20with%20default%20values. Date of access: 2023/08/19.
3. Microsoft. 2021. _Connection strings._ https://learn.microsoft.com/en-us/ef/core/miscellaneous/connection-strings Date of access: 2023/08/19.
4. Microsoft. 2022a. _Tutorial: Open a project from a repo._ https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022 Date of access: 2023/08/19.
5. Microsoft. 2022b. _Edit an api._ https://learn.microsoft.com/en-us/azure/api-management/edit-api Date of access: 2023/08/30.
6. Microsoft. 2022c. _Troubleshoot http 500 internal service errors._ https://learn.microsoft.com/en-us/azure/bot-service/bot-service-troubleshoot-500-errors?view=azure-bot-service-4.0&tabs=dotnetwebapi Date of access: 2023/08/30.
7. Microsoft. 2023a. _Entity framework core tools reference - .Net core cli._ https://learn.microsoft.com/en-us/ef/core/cli/dotnet Date of access: 2023/08/17.
8. Microsoft. 2023b. _Scaffolding (reverse engineering)._ https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli Date of access: 2023/08/19.
9. Microsoft. 2023c. _Azure private link for azure sql database and azure synapse analytics._ https://learn.microsoft.com/en-us/azure/azure-sql/database/private-endpoint-overview?view=azuresql#how-to-set-up-private-link-for-azure-sql-database Date of access: 2023/08/19.
10. Microsoft. 2023d. _Get started with swashbuckle and asp.Net core._ https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio Date of access: 2023/03/21.
11. Microsoft. 2023e. _Global.Json overview._ https://learn.microsoft.com/en-us/dotnet/core/tools/global-json Date of access: 2023/08/21.
12. Microsoft. 2023f. _Install .Net on windows._ https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70 Date of access: 2023/08/21.
13. Microsoft. 2023g. _Assign azure ad roles to users._ https://learn.microsoft.com/en-us/azure/active-directory/roles/manage-roles-portal Date of access: 2023/08/31.
14. Microsoft. 2023h. _Assign a user as an administrator of an azure subscription._ https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal-subscription-admin Date of access: 2023/08/31.
15. Microsoft. 2023i. _Tutorial: Monitor published apis._ https://learn.microsoft.com/en-us/azure/api-management/api-management-howto-use-azure-monitor#diagnostic-logs Date of access: 2023/08/30.
16. Microsoft. 2023j. _Use web api conventions._ https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/conventions?view=aspnetcore-6.0 Date of access: 2023/08/31.
17. Rick, A. & Kirk, L. 2023. _Tutorial: Create a web api with asp.Net core_. https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio Date of access: 2023/08/17.
18. Soucoup, M. 2022. _Publish an asp.Net core web api to azure api management with visual studio._ https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0 Date of access: 2023/08/19.
19. StackOverflow. 2014. _Git ignore vs. Exclude vs. Assume-unchanged._ https://stackoverflow.com/questions/23097368/git-ignore-vs-exclude-vs-assume-unchanged#:~:text=git%2Finfo%2Fexclude%20is%20the,that%20are%20not%20currently%20tracked. Date of access: 2023/08/19.
20. StackOverflow. 2018a. _Using .Gitignore file to hide appsettings.Json does not actually hide it._ https://stackoverflow.com/questions/49930776/using-gitignore-file-to-hide-appsettings-json-does-not-actually-hide-it#:~:text=gitignore%20will%20ignore%20all%20files,json%20file. Date of access: 2023/08/19.
21. StackOverflow. 2018b. _Add a visual studio project to an existing git repository._ https://stackoverflow.com/questions/50864953/add-a-visual-studio-project-to-an-existing-git-repository Date of access: 2023/08/19.
22. StackOverflow. 2020. _.Net core web api, jwt and swagger - 401 is showing as undocumented instead of unauthorized._ https://stackoverflow.com/questions/61150329/net-core-web-api-jwt-and-swagger-401-is-showing-as-undocumented-instead-of-u Date of access: 2023/08/31.
23. StackOverflow. 2021a. _Cannot publish asp.Net web api to azure app service._ https://stackoverflow.com/questions/68705685/cannot-publish-asp-net-web-api-to-azure-app-service Date of access: 2023/08/21.
24. StackOverflow. 2021b. _Why is my azure api returning 500 internal server error when it works in a local environment?_ https://stackoverflow.com/questions/65646595/why-is-my-azure-api-returning-500-internal-server-error-when-it-works-in-a-local/77009326#77009326 Date of access: 2023/08/30.
25. VKiq. 2022. _Publishing to azure from vs2019 failed due to not seeing addswaggergen._ https://learn.microsoft.com/en-us/answers/questions/731287/publishing-to-azure-from-vs2019-failed-due-to-not Date of access: 2023/08/21.

