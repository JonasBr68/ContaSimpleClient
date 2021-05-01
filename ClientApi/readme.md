# How-to: Client generation

> see https://aka.ms/autorest

* load swagger json definition
e.g.  `curl https://api.contasimple.com/docs/v2 | jq . -rSM > contasimple.json`
* call `autorest`

``` yaml
input-file: ./contasimple.json    # or download another
csharp:
  namespace: CloudCraic.ContaSimple.ClientApi
  output-folder: ./
  override-client-name: ContaSimpleApi
```