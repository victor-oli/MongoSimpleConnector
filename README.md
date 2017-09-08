Link do Nuget: https://www.nuget.org/packages/MongoSimpleConnector/

Como Usar:

1. Configurando o MongoDB:
´´´
MongoManager.Config("connectionstring", "database_name");
´´´

2. Carregando uma Collection:
´´´
IMongoCollection<type_of_collection> collection = MongoManager.Open<type_of_collection>("collection_name");
´´´
