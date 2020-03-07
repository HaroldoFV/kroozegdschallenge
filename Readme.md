 
## Endpoints 

## endpoint : api/cruises/companies/1
metodo: GET
Descrição : retorna as informações de uma compania

 
endpoint : api/cruises/cabinValue/10000/portCharge/1000/totalValue/12000/rate
metodo: GET
Descrição : obter algum outro imposto que não seja a taxa portuaria

 

endpoint : api/cruises/discount
metodo: POST
Descrição : verificar se o segundo passageiro possui algum desconto com base no preço do primeiro passageiro
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



endpoint : api/cruises/GetInstallments/fullPrice/400
metodo: GET
Descrição : retorna o número máximo de parcelas com base no preço total



endpoint : api/cruises/translateXML
metodo: GET
Descrição : retorna os dados do arquivo Cruises.xml



endpoint : api/movies
metodo: GET
Descrição : retorna uma lista de filmes



endpoint : api/director
metodo: GET
Descrição : retorna o nome do diretor dos filmes de star wars

