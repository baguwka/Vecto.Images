# Vecto.Images
vecto task

### Get editor settings so you can build up a view with correct UI elements:

```
curl --location --request GET 'http://localhost:5000/api/v1/images/editor'
```

response example:

```
{
    "fields": [
        {
            "name": "Resize to px",
            "editorStrategy": "RawInput",
            "key": "Vecto.Images.Plugins.Resizer.ResizerPluginData",
            "value": {
                "pixelsHeight": 0,
                "pixelsWidth": 0
            }
        },
        {
            "name": "Add blur of pixels size",
            "editorStrategy": "RawInput",
            "key": "Vecto.Images.Plugins.BlurPlugin.BlurPluginData",
            "value": {
                "pixels": 0
            }
        },
        {
            "name": "Convert to grayscale",
            "editorStrategy": "Checkbox",
            "key": "Vecto.Images.Plugins.GrayscalePlugin.GrayscalePluginData",
            "value": {
                "apply": false
            }
        }
    ]
}
```

With this structure you can render the proper UI

### • Image#1: resize to 100 pixels, add blur 2 pixels size

```
curl --location --request POST 'http://localhost:5000/api/v1/images/' \
--form 'file=@"/C:/Users/ttehb/OneDrive/test.png"' \
--form 'data="{
    \"fields\": [{
            \"key\": \"Vecto.Images.Plugins.Resizer.ResizerPluginData\",
            \"value\": {
                \"pixelsHeight\": 100,
                \"pixelsWidth\": 100
            }
        }, {
            \"key\": \"Vecto.Images.Plugins.BlurPlugin.BlurPluginData\",
            \"value\": {
                \"pixels\": 2
            }
        }
    ]
}"'
```

### • Image#2: resize to 100 pixels

```
curl --location --request POST 'http://localhost:5000/api/v1/images/' \
--form 'file=@"/C:/Users/ttehb/OneDrive/test.png"' \
--form 'data="{
    \"fields\": [{
            \"key\": \"Vecto.Images.Plugins.Resizer.ResizerPluginData\",
            \"value\": {
                \"pixelsHeight\": 100,
                \"pixelsWidth\": 100
            }
        }
    ]
}"'

```

### • Image#3: resize to 150 pixels, add blur 5 pixels size, convert to grayscale

```
curl --location --request POST 'http://localhost:5000/api/v1/images/' \
--form 'file=@"/C:/Users/ttehb/OneDrive/test.png"' \
--form 'data="{
    \"fields\": [{
            \"key\": \"Vecto.Images.Plugins.Resizer.ResizerPluginData\",
            \"value\": {
                \"pixelsHeight\": 150,
                \"pixelsWidth\": 150
            }
        }, {
            \"key\": \"Vecto.Images.Plugins.BlurPlugin.BlurPluginData\",
            \"value\": {
                \"pixels\": 5
            }
        }, {
            \"key\": \"Vecto.Images.Plugins.GrayscalePlugin.GrayscalePluginData\",
            \"value\": {
                \"apply\": true
            }
        }
    ]
}"'
```
