# Unit Conversion API

This API allows for unit conversions to be made with the provided parameters.

## Endpoint
- Make a `POST` REST API request to the follow address.
    - `serverIp/unitConversion`

## Parameters
- `type`: Whether the unit is a base unit (e.g., length is in meters in the SI system) or a derived unit.
- `quantity`: What is being measured (e.g, time, length, mass, etc.).
- `magnitude`: The magnitude of the unit the user wants to convert from.
- `unit_from`: The unit the value is currently in.
- `unit_to`: The unit to convert the value to.

    ```json
    {
    "type": "base",
    "quantity": "length", 
    "magnitude": "2.54",
    "unit_from": "cm",
    "unit_to": "in"
    }
    ```

## Response
- `Response`: A `JSON` containing the converted magnitude and the conversion factor used.
    
    ```json
    {
    "magnitude": "1",
    "factor": "0.3937007874"
    }
    ```