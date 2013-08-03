#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.81319 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询相关的商品推广数据 Response
    /// </summary>
    public class JingdongUnionPromotiongoodQueryResponse : JdResponse
    {
        /// <summary>
        /// 商品推广对象列表
        /// </summary>
        [XmlElement("good_list")]
        [JsonProperty("good_list")]
        public List<GoodSafVo> GoodList
        {
            get;
            set;
        }

        /// <summary>
        /// 总个数,如果为null和设置field时没有设置该属性则在结果中不显示
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Decimal> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 返回的结果是否是默认的推广数据
        /// </summary>
        [XmlElement("isDefault")]
        [JsonProperty("isDefault")]
        public Nullable<Boolean> IsDefault
        {
            get;
            set;
        }

    }
}