# NOTE: This file is auto generated by OpenAPI Generator 7.0.1-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.ApiResponse do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :code,
    :type,
    :message
  ]

  @type t :: %__MODULE__{
    :code => integer() | nil,
    :type => String.t | nil,
    :message => String.t | nil
  }

  def decode(value) do
    value
  end
end

