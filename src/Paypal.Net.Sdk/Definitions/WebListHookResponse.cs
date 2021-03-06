﻿using Newtonsoft.Json;

namespace Paypal.Net.Sdk.Definitions {

  public partial class WebListHookResponse
  {
    [JsonProperty("webhooks")]
    public Webhook[] Webhooks { get; set; }
  }
}