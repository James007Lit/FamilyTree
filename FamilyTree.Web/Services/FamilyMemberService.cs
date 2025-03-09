using FamilyTree.Web.Models;
using System.Net.Http.Json;

namespace FamilyTree.Web.Services
{
    public class FamilyMemberService
    {
        private readonly HttpClient _http;

        public FamilyMemberService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<FamilyMember>> GetFamilyMembers()
        {
            return await _http.GetFromJsonAsync<List<FamilyMember>>("api/familymembers") ?? new();
        }

        public async Task AddFamilyMember(FamilyMember member)
        {
            await _http.PostAsJsonAsync("api/familymembers", member);
        }
    }
}
