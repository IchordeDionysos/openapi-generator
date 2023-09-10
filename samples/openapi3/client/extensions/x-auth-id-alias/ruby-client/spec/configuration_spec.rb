=begin
#OpenAPI Extension x-auth-id-alias

#This specification shows how to use x-auth-id-alias extension for API keys.

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 7.0.1-SNAPSHOT

=end

require 'spec_helper'

describe XAuthIDAlias::Configuration do
  let(:config) { XAuthIDAlias::Configuration.default }

  before(:each) do
    # uncomment below to setup host and base_path
    # require 'URI'
    # uri = URI.parse("http://petstore.swagger.io:80/v2")
    # XAuthIDAlias.configure do |c|
    #   c.host = uri.host
    #   c.base_path = uri.path
    # end
  end

  describe '#base_url' do
    it 'should have the default value' do
      # uncomment below to test default value of the base path
      # expect(config.base_url).to eq("http://petstore.swagger.io:80/v2")
    end

    it 'should remove trailing slashes' do
      [nil, '', '/', '//'].each do |base_path|
        config.base_path = base_path
        # uncomment below to test trailing slashes
        # expect(config.base_url).to eq("http://petstore.swagger.io:80/v2")
      end
    end
  end
end
