using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool IsCanvasContext = false;
        SignedAuthentication auth = new SignedAuthentication();
        if (Request.Params[WebConstants.SignedRequestParam] != null)
        {
            IsCanvasContext = auth.IsAuthenticatedCanvasUser(Request.Params[WebConstants.SignedRequestParam]);
        }

        if (IsCanvasContext)
        {
            //Proper Canvas Context
            RootObject contextObj = auth.GetCanvasContextData(Request.Params[WebConstants.SignedRequestParam]);
            lbl_Greet.Text = "Canvas Context oAuth Token : " + contextObj.client.oauthToken + "== ContactID : " + contextObj.context.environment.parameters.contactID + "== InstanceURL : " + contextObj.context.environment.parameters.clInstanceUrl;
            Session["oAuthToken"] = contextObj.client.oauthToken;
            connectleaderVP.Src = contextObj.context.environment.parameters.clInstanceUrl;
            string relatedObjectId = contextObj.context.environment.parameters.contactID;
            salesforceVP.Src = contextObj.client.instanceUrl+"/apex/extraview"+"?id="+relatedObjectId;
        }
        else
        {
            //Not from Canvas Context
            lbl_Greet.Text = "Hi Anonymous User";
            connectleaderVP.Src = "http://www.connectleader.com";
        }
    }
}