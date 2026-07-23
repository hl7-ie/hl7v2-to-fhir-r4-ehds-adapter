package ie.hl7.ehds.adapter.integration;

import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.post;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.content;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.jsonPath;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.MediaType;
import org.springframework.test.web.servlet.MockMvc;

/**
 * Integration test for the conversion REST endpoint.
 */
@SpringBootTest
@AutoConfigureMockMvc
class ConvertControllerIntegrationTest {

    @Autowired
    private MockMvc mockMvc;

    @Test
    void convertReturnsValidFhirBundle() throws Exception {
        mockMvc.perform(post("/api/v1/convert")
                .contentType(MediaType.TEXT_PLAIN)
                .content("MSH|^~\\&|SENDING|FACILITY|RECEIVING|FACILITY|20260101120000||ADT^A01|123|P|2.5"))
            .andExpect(status().isOk())
            .andExpect(content().contentType(MediaType.APPLICATION_JSON))
            .andExpect(jsonPath("$.resourceType").value("Bundle"))
            .andExpect(jsonPath("$.type").value("collection"))
            .andExpect(jsonPath("$.entry").isArray());
    }
}
