﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Templates;
using MailChimp.Api.Net.Enum;
using MailChimp.Api.Net.Helper;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Templates
{
    // ====================================================================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Manage your MailChimp templates. A template is an HTML file used to create the layout and basic design for a campaign.
    // ====================================================================================================================================

    public class MailChimpTemplates
    {
        /// <summary>
        /// Get all templates
        /// </summary>
        public async Task<RootTemplate> GetTemplatesAsync()
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable, SubTargetType.not_applicable);

            return await BaseOperation.GetAsync<RootTemplate>(endpoint);
        }

        /// <summary>
        /// Get information about a specific template
        /// <param name="template_id">The unique id for the template.</param>
        /// </summary>
        public async Task<Template> GetSpecificTemplateAsync(string template_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable, SubTargetType.not_applicable, template_id);

            return await BaseOperation.GetAsync<Template>(endpoint);
        }

        /// <summary>
        /// Delete a specific template
        /// <param name="template_id">The unique id for the template</param>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteATemplateAsync(string template_id)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.templates, SubTargetType.not_applicable, SubTargetType.not_applicable, template_id);

            return await BaseOperation.DeleteAsync(endpoint);
            //HttpResponseMessage result;
            //using (var client = new HttpClient())
            //{
            //    try
            //    {
            //        Authenticate.ClientAuthentication(client);

            //        result = await client.DeleteAsync(endpoint).ConfigureAwait(false);
            //    }
            //    catch (Exception ex)
            //    {

            //        throw ex;
            //    }
            //}
            //return result;

        }
    }
}
