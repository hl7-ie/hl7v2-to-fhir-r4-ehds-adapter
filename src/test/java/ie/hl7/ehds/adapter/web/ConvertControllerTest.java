package ie.hl7.ehds.adapter.web;

import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.post;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.content;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.WebMvcTest;
import org.springframework.http.MediaType;
import org.springframework.test.web.servlet.MockMvc;

/**
 * Tests for {@link ConvertController}.
 */
@WebMvcTest(ConvertController.class)
class ConvertControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @Test
    void convertReturnsJsonBundle() throws Exception {
        mockMvc.perform(post("/api/v1/convert")
                .contentType(MediaType.TEXT_PLAIN)
                .content("MSH|^~\\&|TEST"))
            .andExpect(status().isOk())
            .andExpect(content().contentType(MediaType.APPLICATION_JSON));
    }
}
