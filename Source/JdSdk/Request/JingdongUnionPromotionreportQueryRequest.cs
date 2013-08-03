#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:05.21621 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 查询站长的推广效果数据 Request
    /// </summary>
    public class JingdongUnionPromotionreportQueryRequest : IJdRequest<JingdongUnionPromotionreportQueryResponse>
    {
        /// <summary>
        /// 起始时间,日期格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2013-05-0900:00:00</example>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,日期格式:yyyy-MM-ddHH:mm:ss
        /// </summary>
        /// <example>2013-05-3000:00:00</example>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public DateTime EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <example>1</example>
        [XmlElement("pageIndex")]
        [JsonProperty("pageIndex")]
        public Decimal PageIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 每页显示条数,上限为20
        /// </summary>
        /// <example>20</example>
        [XmlElement("pageSize")]
        [JsonProperty("pageSize")]
        public Decimal PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 需要返回返回的字段列表
        /// </summary>
        /// <example>report_skuId,report_itemNum,report_shopName,report_itemPrice,report_commRatio,report_sourceType,report_orderNo,report_unionId,report_commision,report_itemName,report_orderStatus,totalCount</example>
        [XmlElement("fields")]
        [JsonProperty("fields")]
        public Nullable<Decimal> Fields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.promotionreport.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("startdate" ,this.StartDate);
            paramters.Add("enddate" ,this.EndDate);
            paramters.Add("pageindex" ,this.PageIndex);
            paramters.Add("pagesize" ,this.PageSize);
            paramters.Add("fields" ,this.Fields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("startDate", this.StartDate);
            RequestValidator.ValidateRequired("endDate", this.EndDate);
            RequestValidator.ValidateRequired("pageIndex", this.PageIndex);
            RequestValidator.ValidateRequired("pageSize", this.PageSize);
        }

    }
}