# DesafioApiRest
****
Proyect of test for to show my knowledge in developer .Net Core.
## Proycts
1. [DesafioJordanRodriguesApiRest](#general-API)
2. [DesafioJordanRodriguesApiRest.Application](#aplicacion)
3. [DesafioJordanRodriguesApiRest.Data](#data)
4. [DesafioJordanRodriguesApiRest.Domain](#domain)
<a name="general-API"></a>
<a name="aplicacion"></a>
<a name="data"></a>
<a name="domain"></a>
### General Info Proyect, "DesafioJordanRodriguesApiRest".
***
This proyect is the API REST. Proyect that interact with user, that depends:
* [DesafioJordanRodriguesApiRest.Data](#data).<br>
Also use the proyect methods of:
* [DesafioJordanRodriguesApiRest.Application](#aplicacion)
### General Info Proyect, "DesafioJordanRodriguesApiRest.Application".
***
This proyect has the logic, is charge the interaction with DB. , that depends
* [DesafioJordanRodriguesApiRest.Domain](#data).<br>
### General Info Proyect, "DesafioJordanRodriguesApiRest.Data".
This proyect has conection with DB and  do execution scripts, that depends:
* [DesafioJordanRodriguesApiRest.Domain](#domain)
* [DesafioJordanRodriguesApiRest.Application](#aplicacion)
### General Info Proyect, "DesafioJordanRodriguesApiRest.Domain".
***
This proyect has the EF:
### Deployment.
http://www.desafiojordanrodriguez.somee.com/swagger/index.html
