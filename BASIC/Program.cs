using BASIC.Managers.CardServiceManager;
using BASIC.Managers.CardServiceManager.EsbServiceManager;
using BASIC.Managers.CardServiceManager.WebServiceManager;


// A.) Calling WebService
var webServiceRequest = new WebService.Entities.Common.CardValidationRequest();
IWebServiceManager webServiceManager = new WebServiceManager();
var webServiceResponse = CardServiceManager.Instance.ValidateDebitCardRequest(webServiceRequest, webServiceManager);

// B.) Esb Call
var esbServiceRequest = new EsbService.Entities.Common.CardValidationRequest();
IEsbServiceManager esbServiceManager = new EsbServiceManager();
var esbServiceResponse = CardServiceManager.Instance.ValidateDebitCardRequest(esbServiceRequest, esbServiceManager);

// C.) OnlyEsb Call
var onlyServiceRequest = new EsbService.Entities.NonCommon.DoCashWithDrawalRequest();
IEsbServiceManager onlyServiceServiceManager = new EsbServiceManager();
var onlyEsbServiceResponse = onlyServiceServiceManager.DoCash(onlyServiceRequest);
