# ConsumingExternalApis
# Documentation
## CEP Query Endpoint

This API provides an endpoint for querying Brazilian ZIP codes (CEP) using the ViaCep API.

### Endpoint

- **URL:** `/api/consulta-cep/<cep>`
- **Method:** `GET`
- **Description:** Query details for a specific Brazilian ZIP code (CEP).

### Request

- **Parameters:**
  - `<cep>` (Path Parameter): The Brazilian ZIP code to query.

### Response

- **Success Response:**
  - **Code:** 200 OK
  - **Content:**
    ```json
    {
      "cep": "12345-678",
      "logradouro": "Rua Example",
      "bairro": "Example District",
      "localidade": "Example City",
      "uf": "EX",
      "ibge": "1234567",
      "gia": "9876",
      "ddd": "99",
      "siafi": "8765"
    }
    ```

- **Error Responses:**
  - **Code:** 500 Internal Server Error
    - **Content:**
      ```json
      {
        "erro": "Error querying the CEP"
      }
      ```

