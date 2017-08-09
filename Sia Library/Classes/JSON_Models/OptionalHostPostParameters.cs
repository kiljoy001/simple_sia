using System;
using System.Collections.Generic;
using System.Text;

//Json class object to be used for /host[POST] command (PostHost).
namespace simple_sia_library.Classes.JSON_Models
{
    class OptionalHostPostParameters
    {
        bool? acceptingcontracts { get; set; }
        byte? maxdownloadbatchsize { get; set; }
        Block maxduration { get; set; }
        byte? maxrevisebatchsize { get; set; }
        string netaddress { get; set; }
        Block windowsize { get; set; }
        Collateral collateral { get; set; }
        Decimal? collateralbudget { get; set; }
        Decimal? maxcollateral { get; set; }
        Decimal? mincontractprice { get; set; }
        MinDownloadBandwidthPrice mindownloadbandwidthprice { get; set; }
        MinStoragePrice minstorageprice { get; set; }
        MinUploadBandwidthPrice minuploadbandwidthprice { get; set; }
    }
}
