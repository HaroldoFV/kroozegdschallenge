 
## Endpoints 

endpoint : api/cruises/companies/1 <br/>
metodo: GET <br/>
Descrição : retorna as informações de uma compania <br/><br/><br/>

 
endpoint : api/cruises/cabinValue/10000/portCharge/1000/totalValue/12000/rate <br/>
metodo: GET <br/>
Descrição : obter algum outro imposto que não seja a taxa portuaria <br/><br/><br/>

 

endpoint : api/cruises/discount <br/>
metodo: POST <br/>
Descrição : verificar se o segundo passageiro possui algum desconto com base no preço do primeiro passageiro <br/>
body: 
	{
	 "PassengerCruise":
		[
			{
			"CruiseCode":"1",
			"TotalValue":1000,
			"CabinValue": 1000,
			"PortCharge": 222,
			"ShipName": "",
			"PassengerCode":""
			},
			{
			"CruiseCode":"1",
			"TotalValue":1000,
			"CabinValue": 700,
			"PortCharge": 222,
			"ShipName": "",
			"PassengerCode":""
			}
	 	]
	}
<br/><br/><br/>


endpoint : api/cruises/GetInstallments/fullPrice/400 <br/>
metodo: GET <br/>
Descrição : retorna o número máximo de parcelas com base no preço total <br/>
<br/><br/><br/>


endpoint : api/cruises/translateXML <br/>
metodo: GET <br/>
Descrição : retorna os dados do arquivo Cruises.xml <br/>
<br/><br/><br/>


endpoint : api/movies <br/>
metodo: GET <br/>
Descrição : retorna uma lista de filmes <br/><br/><br/>



endpoint : api/director <br/>
metodo: GET <br/>
Descrição : retorna o nome do diretor dos filmes de star wars <br/><br/><br/>

