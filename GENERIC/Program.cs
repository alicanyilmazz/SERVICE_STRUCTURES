
//  ValidateDebitCardRequest() Called From ESB
using GENERIC.Managers.CardServiceManager;
using GENERIC.Managers.CardServiceManager.EsbServiceManager;
using GENERIC.Managers.CardServiceManager.WebServiceManager;

var esbRequest = new EsbService.Entities.Common.CardValidationRequest();
var esbManager = new EsbServiceManager<EsbService.Entities.Common.CardValidationRequest, EsbService.Entities.Common.CardValidationResponse>();
var esbResponse = CardServiceManager<EsbService.Entities.Common.CardValidationRequest, EsbService.Entities.Common.CardValidationResponse>.Current.ValidateDebitCardRequest(esbRequest, esbManager);


//  ValidateDebitCardRequest() Called From WebService
var webRequest = new WebService.Entities.Common.CardValidationRequest();
var webManager = new WebServiceManager<WebService.Entities.Common.CardValidationRequest, WebService.Entities.Common.CardValidationResponse>();
var webResponse = CardServiceManager<WebService.Entities.Common.CardValidationRequest, WebService.Entities.Common.CardValidationResponse>.Current.ValidateDebitCardRequest(webRequest, webManager);

// The DoCash method is available in ESB but not in WebServices. In this case, you see an example of how the implementation and invocation process should be done.
var esbRequestOnly = new EsbService.Entities.NonCommon.DoPinChangeRequest();
var esbManagerOnly = new EsbServiceManager<EsbService.Entities.NonCommon.DoPinChangeRequest, EsbService.Entities.NonCommon.DoPinChangeResponse>().DoPinChange(esbRequestOnly);

var esbRequestOnly2 = new EsbService.Entities.NonCommon.DoCashWithDrawalRequest();
var esbManagerOnly2 = new EsbServiceManager<EsbService.Entities.Base.NoEntity, EsbService.Entities.Base.NoEntity>().DoCashWithDrawal(esbRequestOnly2);